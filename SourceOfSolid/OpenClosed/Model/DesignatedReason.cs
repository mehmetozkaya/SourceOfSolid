namespace SourceOfSolid.OpenClosed.Model
{
    internal class DesignatedReason
    {
        public bool IsDesignated => false;

        public override bool Equals(object obj)
        {
            var reason = obj as DesignatedReason;
            return reason != null &&
                   IsDesignated == reason.IsDesignated;
        }

        public override int GetHashCode()
        {
            return 1884676947 + IsDesignated.GetHashCode();
        }
    }
}
