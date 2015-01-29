﻿using System;
using System.Linq;

namespace Orleankka.TestKit
{
    public class ClientObservableStub : ClientObservable
    {
        protected ClientObservableStub()
            : base(ActorPath.From(typeof(ClientObservableStub), Guid.NewGuid().ToString("D")))
        {}

        public override IDisposable Subscribe(IObserver<Notification> observer)
        {
            return new DisposableStub();
        }

        class DisposableStub : IDisposable
        {
            public void Dispose()
            {}
        }

        public override void Dispose()
        {}
    }
}