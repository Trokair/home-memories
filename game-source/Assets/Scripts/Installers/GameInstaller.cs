using UnityEngine;
using Zenject;
using System.Collections;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Controls>().AsSingle().NonLazy();
    }
}