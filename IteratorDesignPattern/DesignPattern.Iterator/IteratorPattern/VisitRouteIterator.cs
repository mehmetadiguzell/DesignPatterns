using System.Diagnostics.Eventing.Reader;

namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover _visitMover;

        public VisitRouteIterator(VisitRouteMover visitMover)
        {
            _visitMover = visitMover;
        }
        private int currentIndex = 0;
        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex<_visitMover.VisitRouteCount)
            {
                CurrentItem = _visitMover.visitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
