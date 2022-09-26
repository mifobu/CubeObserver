namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private CubeController _controller;

        public TurnLeft(CubeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(CubeController.Direction.Left);
        }
    }
}