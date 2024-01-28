using org.ogre;

namespace MyOgreProgram.Classes
{
    public class MyOgreInputListener : InputListener
    {
        public bool isQuitFlag;
        public CameraMan camMan;

        public MyOgreInputListener()
        {
            isQuitFlag = false;
        }

        public override bool axisMoved(AxisEvent evt)
        {
            return base.axisMoved(evt);
        }

        public override bool buttonPressed(ButtonEvent evt)
        {
            return base.buttonPressed(evt);
        }

        public override bool buttonReleased(ButtonEvent evt)
        {
            return base.buttonReleased(evt);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override void frameRendered(FrameEvent evt)
        {
            base.frameRendered(evt);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool keyPressed(KeyboardEvent evt)
        {

            if (evt.keysym.sym == 27)
            {
                isQuitFlag = true;
            }

            camMan.keyPressed(evt);

            return true;
        }

        public override bool keyReleased(KeyboardEvent evt)
        {
            //return base.keyReleased(evt);
            camMan.keyReleased(evt);
            return true;
        }

        public override bool mouseMoved(MouseMotionEvent evt)
        {
            // return base.mouseMoved(evt);
            camMan.mouseMoved(evt);
            return true;
        }

        public override bool mousePressed(MouseButtonEvent evt)
        {
            return base.mousePressed(evt);
        }

        public override bool mouseReleased(MouseButtonEvent evt)
        {
            return base.mouseReleased(evt);
        }

        public override bool mouseWheelRolled(MouseWheelEvent evt)
        {
            return base.mouseWheelRolled(evt);
        }

        public override bool textInput(TextInputEvent evt)
        {
            return base.textInput(evt);
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override bool touchMoved(TouchFingerEvent evt)
        {
            return base.touchMoved(evt);
        }

        public override bool touchPressed(TouchFingerEvent evt)
        {
            return base.touchPressed(evt);
        }

        public override bool touchReleased(TouchFingerEvent evt)
        {
            return base.touchReleased(evt);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
