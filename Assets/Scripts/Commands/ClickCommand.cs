using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    GameObject _cube;
    Color _color;
    Color _previousColor;

    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    public void Execute()
    {
        _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    public void Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
    }
}
