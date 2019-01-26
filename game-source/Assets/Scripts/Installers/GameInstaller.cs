using UnityEngine;
using Zenject;
using System.Collections;

/**
 * Installs bindings for the game
 */
public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Controls>().AsSingle().NonLazy();
        Container.Bind<Timer>().FromInstance(new Timer(400f)).AsSingle().NonLazy();
    }
}