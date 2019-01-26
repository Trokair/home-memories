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
        Timer timer = new Timer(400f);
        Container.Bind<Controls>().AsSingle().NonLazy();
        Container.Bind<Timer>().FromInstance(timer).AsSingle().NonLazy();
        Object.DontDestroyOnLoad(this);
    }
}