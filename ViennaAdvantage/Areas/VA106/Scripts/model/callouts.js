/*Module Name space initialization*/
; VA106 = window.VA106 || {};

; (function (VA106, $) {

    var Level = VIS.Logging.Level;
    var Util = VIS.Utility.Util;



    /**
    *  Callout Class
      -   must call this function
             VIS.CalloutEngine.call(this, [className]);
    */
    function VA106_CalloutTest() {
        VIS.CalloutEngine.call(this, "VA106.VA106_CalloutTest"); // must call base class (CalloutEngine)
    };


    VA106_CalloutTest.prototype.setTotalAmt = function (ctx, windowNo, mTab, mField, value, oldValue) {
        if (this.isCalloutActive() || value == null) {
            return "";
        }
        this.setCalloutActive(true);
        try { }
        catch (err) {
            this.log.severe(err.toString());
            this.setCalloutActive(false);
            return err.message;
        };
        this.setCalloutActive(false);
        ctx = windowNo = mTab = mField = value = oldvalue = null;
        return "";
    };

    VA106.Model = VA106.Model || {};
    VA106.Model.VA106_CalloutTest = VA106_CalloutTest; //assign object in Model NameSpace



})(VA106, jQuery);











