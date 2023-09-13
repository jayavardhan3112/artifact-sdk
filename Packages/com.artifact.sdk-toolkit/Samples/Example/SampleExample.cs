// -----------------------------------------------------------------------------
//
// Use this sample example C# file to develop samples to guide usage of APIs
// in your package.
//
// -----------------------------------------------------------------------------

namespace Artifact.SdkToolkit
{
    public class MyPublicSampleExampleClass
    {
        public void CountThingsAndDoStuffAndOutputIt()
        {
            var result = new MyPublicRuntimeExampleClass().CountThingsAndDoStuff(1, 2, false);
            Debug.Log("Call CountThingsAndDoStuffAndOutputIt returns " + result);
        }
    }
}