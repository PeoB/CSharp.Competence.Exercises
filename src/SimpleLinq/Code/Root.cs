using System;

namespace SimpleLinq.Code
{
    public class Root
    {
        public Root WithTitle(string title)
        {
            throw new NotImplementedException();
        }

        public string Title
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class RootFactory
    {
        public Root BuildRootUsing(params Func<Root, Root>[] decorators)
        {
            throw new NotImplementedException();
        }
    }
}