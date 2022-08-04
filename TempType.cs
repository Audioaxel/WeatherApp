class TempType
{
    public float Celsius { get; set; }
    public float Kelvin 
    { 
        get
        {
            return this.Celsius + 273.15f;
        } 
        private set
        {
            this.Kelvin = value;
        } 
    }
    public float Farenheit 
    { 
        get
        {
            return this.Celsius * 1.8f + 32f;
        } 
        set
        {
            value=this.Farenheit;
        }
    }  

}

    