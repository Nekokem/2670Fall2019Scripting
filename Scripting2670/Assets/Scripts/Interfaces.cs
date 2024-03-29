﻿using UnityEngine;
using UnityEngine.Events;

public interface IRun
{
    float Speed { get; set; }
    void Run();
    void Run(float f);
}


public interface ITest
{
    void Test();
}

public interface IListen
{
    UnityEvent Event { get; set; }
    IRun newIRunObj { get; set; }
    void Start();
}


public interface IMove
{
    Vector3 location { get; set; }
    void Move(CharacterController controller);
}