using Task6._2;

StreamReader reader = new StreamReader("text.txt");
Text myText=new Text(reader);
myText.WriteToFileSentences();
myText.SearchLongestAndShortestWords();
reader.Close();
