// Use this for initialization
/*void Start()
{
    // Set the path for the credits.txt file
    path = "Assets/Resources/Credits.txt";
    // Create reader &amp; open file
    tr = new StreamReader(path);
    string temp;
    while ((temp = tr.ReadLine()) != null)
    {
        // Read a line of text
        credits.Add(temp);
    }
    // Close the stream
    tr.Close();
    CreateCredits();
}
// Update is called once per frame
void Update()
{
    if (Credits.Count & gt; 0)
     {
        for (int i = 0; i & lt; Credits.Count; i++)
         {
            Credits[i].transform.Translate(new Vector3(0f, 1f, 0f));
        }
    }
}
void CreateCredits()
{
    for (int i = 0; i & lt; credits.Count; i++)
     {
        string c = credits[i];
        Instantiate(creditTextItem);
        creditTextItem.transform.position = GameObject.Find("CreditStart").transform.position;
        creditTextItem.text = c;
        Debug.Log(c);
        Credits.Add(creditTextItem);
    }
}*/