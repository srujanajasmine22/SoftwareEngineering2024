﻿/******************************************************************************
 * Filename    = ReceivedDataService.cs
 *
 * Author      = Likith Anaparty and Vishnu Nair
 *
 * Product     = WhiteBoard
 *
 * Project     = Networking for whiteboard
 *
 * Description = The methods and logic to do after a data and command is received
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteboardGUI.Models;
namespace WhiteboardGUI.Services;

/// <summary>
/// Service for handling received data and managing shape synchronization.
/// </summary>
public class ReceivedDataService
{
    /// <summary>
    /// List of synchronized shapes.
    /// </summary>
    public List<IShape> _synchronizedShapes = new();

    /// <summary>
    /// Event triggered when a shape is received.
    /// </summary>
    public event Action<IShape, Boolean> ShapeReceived;

    /// <summary>
    /// Event triggered when a shape is deleted.
    /// </summary>
    public event Action<IShape> ShapeDeleted;

    /// <summary>
    /// Event triggered when a shape is sent to the back.
    /// </summary>
    public event Action<IShape> ShapeSendToBack;

    /// <summary>
    /// Event triggered when a shape is sent backward.
    /// </summary>
    public event Action<IShape> ShapeSendBackward;

    /// <summary>
    /// Event triggered when a shape is modified.
    /// </summary>
    public event Action<IShape> ShapeModified;

    /// <summary>
    /// Event triggered when a shape is unlocked.
    /// </summary>
    public event Action<IShape> ShapeUnlocked;

    /// <summary>
    /// Event triggered when a shape is locked.
    /// </summary>
    public event Action<IShape> ShapeLocked;

    /// <summary>
    /// Event triggered when all shapes are cleared.
    /// </summary>
    public event Action ShapesClear;

    /// <summary>
    /// The ID of the current service instance.
    /// </summary>
    private int _Id;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReceivedDataService"/> class.
    /// </summary>
    /// <param name="Id">The unique identifier for the instance.</param>
    public ReceivedDataService(int Id)
    {
        _Id = Id;
    }

    /// <summary>
    /// Processes received data and triggers appropriate events based on the message content.
    /// </summary>
    /// <param name="receivedData">The data received as a string.</param>
    /// <returns>Returns 0 on successful processing, or -1 if the data is invalid or from the same sender.</returns>
    public int DataReceived(string receivedData)
    {
        if (receivedData == null)
        {
            return -1;
        }

        int index = receivedData.IndexOf("END");
        int senderId = int.Parse(receivedData.Substring(2, index - 2));

        if (senderId == _Id)
        {
            return -1;
        }

        receivedData = receivedData.Substring(index + "END".Length);

        if (receivedData.StartsWith("DELETE:"))
        {
            string data = receivedData.Substring(7);
            var shape = SerializationService.DeserializeShape(data);

            if (shape != null)
            {
                var shapeId = shape.ShapeId;
                var shapeUserId = shape.UserID;

                var currentShape = _synchronizedShapes
                    .Where(s => s.ShapeId == shapeId && s.UserID == shapeUserId)
                    .FirstOrDefault();
                if (currentShape != null)
                {
                    ShapeDeleted?.Invoke(currentShape); // Deletes the shape based on the received data
                }
            }
        }
        else if (receivedData.StartsWith("CLEAR:"))
        {
            ShapesClear?.Invoke(); // Clears the screen if CLEAR command was received
        }
        else if (receivedData.StartsWith("INDEX-BACK:"))
        {
            string data = receivedData.Substring(11);
            var shape = SerializationService.DeserializeShape(data);

            if (shape != null)
            {
                var shapeId = shape.ShapeId;
                var shapeUserId = shape.UserID;

                var currentShape = _synchronizedShapes
                    .Where(s => s.ShapeId == shapeId && s.UserID == shapeUserId)
                    .FirstOrDefault();
                if (currentShape != null)
                {
                    ShapeSendToBack?.Invoke(currentShape); // Sends the shape to the last layer in the canvas
                }
            }
        }
        else if (receivedData.StartsWith("INDEX-BACKWARD:"))
        {
            string data = receivedData.Substring(15);
            var shape = SerializationService.DeserializeShape(data);

            if (shape != null)
            {
                var shapeId = shape.ShapeId;
                var shapeUserId = shape.UserID;

                var currentShape = _synchronizedShapes
                    .Where(s => s.ShapeId == shapeId && s.UserID == shapeUserId)
                    .FirstOrDefault();
                if (currentShape != null)
                {
                    ShapeSendBackward?.Invoke(currentShape); // Sends the shape one layer back
                }
            }
        }
        else if (receivedData.StartsWith("MODIFY:"))
        {
            string data = receivedData.Substring(7);
            var shape = SerializationService.DeserializeShape(data);
            Debug.WriteLine($"Received shape: {shape}");
            if (shape != null)
            {
                var shapeId = shape.ShapeId;
                var shapeUserId = shape.UserID;

                var currentShape = _synchronizedShapes
                    .Where(s => s.ShapeId == shapeId && s.UserID == shapeUserId)
                    .FirstOrDefault();
                if (currentShape != null)
                {
                    ShapeModified?.Invoke(shape); // Changes the shape identified by its shape_id
                }
            }
        }
        else if (receivedData.StartsWith("CREATE:"))
        {
            string data = receivedData.Substring(7);
            var shape = SerializationService.DeserializeShape(data);
            if (shape != null)
            {
                ShapeReceived?.Invoke(shape, true); // Draws the shape sent over the network
            }
        }
        else if (receivedData.StartsWith("DOWNLOAD:"))
        {
            string data = receivedData.Substring(9);
            var shape = SerializationService.DeserializeShape(data);
            if (shape != null)
            {
                ShapeReceived?.Invoke(shape, false); // For rendering snapshot after downloading
            }
        }
        else if (receivedData.StartsWith("UNLOCK:"))
        {
            string data = receivedData.Substring(7);
            var shape = SerializationService.DeserializeShape(data);
            if (shape != null)
            {
                var existingShape = _synchronizedShapes
                    .FirstOrDefault(s => s.ShapeId == shape.ShapeId);
                if (existingShape != null)
                {
                    existingShape.IsLocked = false;
                    existingShape.LockedByUserID = -1;
                    ShapeUnlocked?.Invoke(existingShape); // Unlocks the shape locked by another user
                }
            }
        }
        else if (receivedData.StartsWith("LOCK:")) 
        {
            string data = receivedData.Substring(5);
            var shape = SerializationService.DeserializeShape(data);
            if (shape != null)
            {
                var existingShape = _synchronizedShapes
                    .FirstOrDefault(s => s.ShapeId == shape.ShapeId);

                if (existingShape != null)
                {
                    if (_Id == 1)
                    {
                        if (existingShape.IsLocked)
                        {
                            receivedData = "UNLOCK:" + receivedData.Substring("LOCK:".Length);
                        }
                        else
                        {
                            existingShape.IsLocked = true;
                            existingShape.LockedByUserID = senderId;
                            ShapeLocked?.Invoke(existingShape); // Locks the shape
                        }
                    }
                    else
                    {
                        existingShape.IsLocked = true;
                        existingShape.LockedByUserID = shape.LockedByUserID;
                        ShapeLocked?.Invoke(existingShape);
                    }
                }
            }
        }

        return 0;
    }
}
