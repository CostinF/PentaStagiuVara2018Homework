using System;

namespace Library
{
    public class DisplayPost
    {
        private string PostContent;
        private string Author;
        private DateTime DateOfPost;

        public DisplayPost(string postContent, string author, DateTime dateOfPost)
        {
            this.PostContent = postContent;
            this.Author = author;
            this.DateOfPost = dateOfPost;
        }

        public override string ToString()
        {
            return $" '{PostContent}' - created by {Author} on {DateOfPost}";
        }
    }
}