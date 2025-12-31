using PGS;
using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Start Service", story: "Initialize the [Service]", category: "Action", id: "f2fcefd96dd526c872b7de8a4b17f036")]
public partial class StartServiceAction : Action
{
    [SerializeReference] public BlackboardVariable<SystemService> Service;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

