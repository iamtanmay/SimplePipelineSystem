namespace Pipelines {
  
  //Smallest unit of pipelines
  public interface ITask{
    
    //Unique identifier
    string ID
    
    //Parent Pipeline ID
    string Pipeline;
    
    //Outcome of task
    string Result;
    
    //Task initialisation actions
    void Initialise();
    
    //Evaluate state: 0 unfinished, -1 failed, 1 passed. Triggered on Event
    int Evaluate(string parameter);    
  }
}
