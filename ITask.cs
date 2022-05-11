namespace Pipelines {
  
  //Smallest unit of pipelines
  public interface ITask{
    
    //Unique Identifier for type
    int ID;
    
    //Evaluate outcome of task. 0 unfinished, [-1, -2, -3,....-n] failed with parameter, [1, 2, 3...n] pass with parameter
    //Called OnEvent
    int Evaluate(string parameter);
    
    //Set up environment for task
    void Initialise();
  }
}
