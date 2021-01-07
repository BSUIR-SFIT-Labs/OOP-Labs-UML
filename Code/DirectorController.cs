
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DirectorController : ClientController {

    public DirectorController() {
    }

    public RemotePrinterController printerController;


    /// <summary>
    /// @param rep 
    /// @return
    /// </summary>
    public object GetReport(string rep) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param rep 
    /// @return
    /// </summary>
    public bool PrintReport(string rep) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @return
    /// </summary>
    public bool Shutdown() {
        // TODO implement here
        return False;
    }

}