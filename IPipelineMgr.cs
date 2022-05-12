using System;
using System.Collections.Generic;

using namespace Pipelines{

  //User Pipeline states
  public interface IUser{

      //User ID
      string ID;

      //Pipeline IDs, States
      Dictionary<string, IState> states;
    }
  }
}
