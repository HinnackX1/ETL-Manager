public delegate bool IfDelegate(string Value1, string Operator, string Value2);

class IfObject{

    public IfObject()
    {
        IfDelegate ifStmt = new IfDelegate(IfStatement);

        ifStmt.Invoke("100", "==", "100");
    }

    public bool IfStatement(dynamic Value1, string Operator, dynamic Value2)
    {
        switch(Operator) 
        {
        case "==":
            if(Value1 == Value2)
            {
                return true;
            }else{
                return false;
            }
        case "!=":
            if(Value1 != Value2)
            {
                return true;
            }else{
                return false;
            }
        default:
            return false;
        }
    }
}