using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    static class SerializeScores
    {
        public static void checkScoresAchievs(difficulty DIFF, int seconds, List<Achievement> achievements)
        {
            SortedList<Score, Score> highScores = getScores(DIFF);
            bool f = false;
            for (int i = 0; i < 10; i++)
            {
                if (highScores.Count <= i || highScores.Keys[i].Minutes * 60 + highScores.Keys[i].Seconds > seconds)
                {
                    f = true;
                    break;
                }

            }
            if (f)
            {
                Name form = new Name();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string name = form.name;
                    Score temp = new Score(name, seconds / 60, seconds % 60);
                    highScores.Add(temp, temp);
                }
                while (highScores.Count > 10)
                    highScores.RemoveAt(highScores.Count - 1);
            }
            saveScores(DIFF, highScores);
            bool changes = false;
            foreach (var item in achievements)
            {
                if (item.diffRequired == DIFF && item.secondsRequired >= seconds && !item.iSUnlocked())
                {
                    item.Unlock();
                    MessageBox.Show("Congratulations, you unlocked " + item.getName());
                    changes = true;
                }
            }
            if (changes) // if achievements unlocked, save the changes
            {
                using (FileStream stream = new FileStream("Assets/achievements.lst", FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, achievements);
                    stream.Close();
                }
            }
        }

        private static SortedList<Score, Score> getScores(difficulty d)
        {
            SortedList<Score, Score> scores;
            switch (d)
            {
                case difficulty.EASY:
                    try
                    {
                        using (FileStream stream = new FileStream("Assets/easy.lst", FileMode.Open))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            scores = (SortedList<Score, Score>)formatter.Deserialize(stream);
                            stream.Close();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        scores = new SortedList<Score, Score>();
                    }
                    break;
                case difficulty.INTERMEDIATE:
                    try
                    {
                        using (FileStream stream = new FileStream("Assets/medium.lst", FileMode.Open))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            scores = (SortedList<Score, Score>)formatter.Deserialize(stream);
                            stream.Close();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        scores = new SortedList<Score, Score>();
                    }
                    break;
                case difficulty.HARD:
                    try
                    {
                        using (FileStream stream = new FileStream("Assets/hard.lst", FileMode.Open))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            scores = (SortedList<Score, Score>)formatter.Deserialize(stream);
                            stream.Close();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        scores = new SortedList<Score, Score>();
                    }
                    break;
                default:
                    scores = new SortedList<Score, Score>();
                    break;
            }
            return scores;
        }

        private static void saveScores(difficulty d, SortedList<Score, Score> scores)
        {
            switch (d)
            {
                case difficulty.EASY:
                    using (FileStream stream = new FileStream("Assets/easy.lst", FileMode.Create))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, scores);
                        stream.Close();
                    }
                    break;
                case difficulty.INTERMEDIATE:
                    using (FileStream stream = new FileStream("Assets/medium.lst", FileMode.Create))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, scores);
                        stream.Close();
                    }
                    break;
                case difficulty.HARD:
                    using (FileStream stream = new FileStream("Assets/hard.lst", FileMode.Create))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, scores);
                        stream.Close();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
