using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class ArrayTests
    {
        public List<Test> tests { get; set; }

        public ArrayTests(List<Test> tests)
        {
            this.tests = tests;
        }

        public ArrayTests GetTestsByCategory(Category category)
        {
            return new ArrayTests(tests.FindAll(s => s.Category == category));
        }
    }
}
