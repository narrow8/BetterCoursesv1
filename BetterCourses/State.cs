using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCourses
{
    class State
    {
        public string id;
        public string project;
        public string iteration;
        public string created;
        public Predictions[] predictions;

        public string getBestPrediction()
        {
            string best = "";
            double n = 0;

            foreach(var prediction in predictions)
            {
                if (prediction.probability > n)
                {
                    n = prediction.probability;
                    best = prediction.tagName;
                }
            }

            return best;
        }
    }
}
