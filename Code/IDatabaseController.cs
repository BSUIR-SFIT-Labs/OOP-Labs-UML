
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IDatabaseController {


    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Add(object obj);

    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Delete(object obj);

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public bool DeleteById(int id);

    /// <summary>
    /// @param obj 
    /// @return
    /// </summary>
    public bool Update(object obj);

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public object GetById(int id);

    /// <summary>
    /// @param str 
    /// @param login 
    /// @param pass 
    /// @return
    /// </summary>
    public string SetConnectionStr(string str, string login, string pass);

    /// <summary>
    /// @param request 
    /// @return
    /// </summary>
    public string ProcessRequest(string request);

}