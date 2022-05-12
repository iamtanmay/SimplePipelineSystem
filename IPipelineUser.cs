using System;
using System.Collections.Generic;

using namespace Pipelines{

  //Keeps track of Pipelines for User
  public interface IPipelineUser{

      //Unique Identifier
      int ID;

      //States of pipelines for User
      Dictionary<int, IPipelineState> pipelinesStates;
    }
  }
}
