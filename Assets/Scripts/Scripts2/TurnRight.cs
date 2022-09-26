namespace Chapter.Command
{
    public class TurnRight : Command
    {
        private CubeController _controller;

        public TurnRight(CubeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(CubeController.Direction.Right);
        }
    }
}