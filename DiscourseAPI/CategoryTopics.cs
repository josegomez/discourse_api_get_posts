using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscourseAPI
{

    public class CategoryTopics
    {
        public User[] users { get; set; }
        public Primary_Groups[] primary_groups { get; set; }
        public Topic_List topic_list { get; set; }
    }

    public class Topic_List
    {
        public bool? can_create_topic { get; set; }
        public string more_topics_url { get; set; }
        public object draft { get; set; }
        public string draft_key { get; set; }
        public int? draft_sequence { get; set; }
        public int? per_page { get; set; }
        public Topic[] topics { get; set; }
    }

    public class Topic
    {
        public int? id { get; set; }
        public string title { get; set; }
        public string fancy_title { get; set; }
        public string slug { get; set; }
        public int? posts_count { get; set; }
        public int? reply_count { get; set; }
        public int? highest_post_number { get; set; }
        public string image_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_posted_at { get; set; }
        public bool? bumped { get; set; }
        public DateTime bumped_at { get; set; }
        public bool? unseen { get; set; }
        public int? last_read_post_number { get; set; }
        public int? unread { get; set; }
        public int? new_posts { get; set; }
        public bool? pinned { get; set; }
        public object unpinned { get; set; }
        public bool? visible { get; set; }
        public bool? closed { get; set; }
        public bool? archived { get; set; }
        public int? notification_level { get; set; }
        public bool? bookmarked { get; set; }
        public bool? liked { get; set; }
        public string[] tags { get; set; }
        public int? views { get; set; }
        public int? like_count { get; set; }
        public bool? has_summary { get; set; }
        public string archetype { get; set; }
        public string last_poster_username { get; set; }
        public int? category_id { get; set; }
        public bool? pinned_globally { get; set; }
        public object featured_link { get; set; }
        public bool? has_accepted_answer { get; set; }
        public int? vote_count { get; set; }
        public bool? can_vote { get; set; }
        public bool? user_voted { get; set; }
        public Poster[] posters { get; set; }
    }

    public class Poster
    {
        public string extras { get; set; }
        public string description { get; set; }
        public int? user_id { get; set; }
        public int? primary_group_id { get; set; }
    }

    public class User
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
    }

    public class Primary_Groups
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string flair_url { get; set; }
        public object flair_bg_color { get; set; }
        public object flair_color { get; set; }
    }

}
