namespace MoshIntermediate
{
    //classes: VideoUpload, VideoReadyForEncoding, SendEmail, VideoStatusProcessing
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var uploadingVideos = new Workflow();

            //add activities to the activity list for the engine to execute
            uploadingVideos.RegisterActivity(new VideoUpload());
            uploadingVideos.RegisterActivity(new VideoReadyForEncoding());
            uploadingVideos.RegisterActivity(new SendEmail());
            uploadingVideos.RegisterActivity(new VideoStatusProcessing());

            //passes the list of activities to the engine to run
            workflowEngine.Run(uploadingVideos);
        }
    }
}
