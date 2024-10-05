namespace CleanCode_CodeStyle10
{
    internal class Program
    {
        public void Enable()
        {
            _enable = true;

            _effects.StartEnableAnimation();
        }

        public void Disable() 
        {
            _enable = false;

            _pool.Free(this);
        }
    }
}
