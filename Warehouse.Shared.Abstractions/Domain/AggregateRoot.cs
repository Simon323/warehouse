﻿namespace Warehouse.Shared.Abstractions.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }
        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        private bool _versionIncremented;
        private readonly List<IDomainEvent> _events = new();

        protected void AddEvent(IDomainEvent @event)
        {
            if (!_events.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;
                _events.Add(@event);
            }
        }

        protected void IncrementVersion()
        {
            if (_versionIncremented)
            {
                return;
            }

            Version++;
            _versionIncremented = true;
        }

        public void ClearEvents() => _events.Clear();
    }
}
