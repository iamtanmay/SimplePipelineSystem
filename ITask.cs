namespace Pipelines {
  
  //Smallest unit of pipelines
  public interface ITask{
    
    //Task ID
    string ID;
    
    //Parent pipeline
    string Pipeline;
    
    //Outcome of task
    string Result;
    
    //Task initialisation
    void Initialise();
    
    //Evaluate state: 0 unfinished, -1 failed, 1 passed
    int Evaluate(string parameter);    
  }
}
