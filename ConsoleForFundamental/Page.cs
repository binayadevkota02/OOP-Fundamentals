class page
{
    public page(int h, int w, string t)
    {
        height = h;
        width = w;
        title = t;

    }
    public int height;
    public int width;

    public string title;

    public void printwebpage()
    {
        Console.WriteLine ($"Height in inch: {height*96}\nwidth in inch: {width*96}\ntitle: {title}"); 
        
    }


}



