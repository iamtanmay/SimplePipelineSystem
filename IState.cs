namespace Pipelines {
  
  //Smallest unit of pipelines
  public interface IState{
    
    //Unique instance identifier
    string ID
    
    //Parent User ID
    string User;
    
    //Parent Pipeline ID
    string Pipeline;
   
    //Current Task
    string Task;
   }
}
