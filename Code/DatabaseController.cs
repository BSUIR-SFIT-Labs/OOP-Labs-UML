
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DatabaseController : IDatabaseController {

    public DatabaseController() {
    }

    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Add(object obj) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Delete(object obj) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public bool DeleteById(int id) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Update(object obj) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public object GetById(int id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param str 
    /// @param login 
    /// @param pass 
    /// @return
    /// </summary>
    public string SetConnectionStr(string str, string login, string pass) {
        // TODO implement here
        return "";
    }

    /// <summary>
    /// @param request 
    /// @return
    /// </summary>
    public string ProcessRequest(string request) {
        // TODO implement here
        return "";
    }

}