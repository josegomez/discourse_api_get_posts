using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscourseAPI
{

    public class TopicResponse
    {
        public Post_Stream post_stream { get; set; }
        public int?[][] timeline_lookup { get; set; }
        public Suggested_Topics[] suggested_topics { get; set; }
        public string[] tags { get; set; }
        public int? id { get; set; }
        public string title { get; set; }
        public string fancy_title { get; set; }
        public int? posts_count { get; set; }
        public DateTime created_at { get; set; }
        public int? views { get; set; }
        public int? reply_count { get; set; }
        public int? like_count { get; set; }
        public DateTime last_posted_at { get; set; }
        public bool? visible { get; set; }
        public bool? closed { get; set; }
        public bool? archived { get; set; }
        public bool? has_summary { get; set; }
        public string archetype { get; set; }
        public string slug { get; set; }
        public int? category_id { get; set; }
        public int? word_count { get; set; }
        public object deleted_at { get; set; }
        public int? user_id { get; set; }
        public object featured_link { get; set; }
        public bool? pinned_globally { get; set; }
        public object pinned_at { get; set; }
        public object pinned_until { get; set; }
        public object draft { get; set; }
        public string draft_key { get; set; }
        public object draft_sequence { get; set; }
        public object unpinned { get; set; }
        public bool? pinned { get; set; }
        public Details details { get; set; }
        public int? current_post_number { get; set; }
        public int? highest_post_number { get; set; }
        public object deleted_by { get; set; }
        public Actions_Summary[] actions_summary { get; set; }
        public int? chunk_size { get; set; }
        public object bookmarked { get; set; }
        public object topic_timer { get; set; }
        public int? message_bus_last_id { get; set; }
        public int? participant_count { get; set; }
        public bool? qa_enabled { get; set; }
        public object voted { get; set; }
        public Last_Answerer last_answerer { get; set; }
        public bool? can_vote { get; set; }
        public int? vote_count { get; set; }
        public bool? user_voted { get; set; }
    }

    public class Post_Stream
    {
        public Post[] posts { get; set; }
        public int?[] stream { get; set; }
    }

    public class Post
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
        public DateTime created_at { get; set; }
        public string cooked { get; set; }
        public int? post_number { get; set; }
        public int? post_type { get; set; }
        public DateTime updated_at { get; set; }
        public int? reply_count { get; set; }
        public object reply_to_post_number { get; set; }
        public int? quote_count { get; set; }
        public int? avg_time { get; set; }
        public int? incoming_link_count { get; set; }
        public int? reads { get; set; }
        public float score { get; set; }
        public bool? yours { get; set; }
        public int? topic_id { get; set; }
        public string topic_slug { get; set; }
        public string display_username { get; set; }
        public object primary_group_name { get; set; }
        public object primary_group_flair_url { get; set; }
        public object primary_group_flair_bg_color { get; set; }
        public object primary_group_flair_color { get; set; }
        public int? version { get; set; }
        public bool? can_edit { get; set; }
        public bool? can_delete { get; set; }
        public bool? can_recover { get; set; }
        public bool? can_wiki { get; set; }
        public bool? read { get; set; }
        public object user_title { get; set; }
        public object[] actions_summary { get; set; }
        public bool? moderator { get; set; }
        public bool? admin { get; set; }
        public bool? staff { get; set; }
        public int? user_id { get; set; }
        public bool? hidden { get; set; }
        public int? trust_level { get; set; }
        public object deleted_at { get; set; }
        public bool? user_deleted { get; set; }
        public object edit_reason { get; set; }
        public bool? can_view_edit_history { get; set; }
        public bool? wiki { get; set; }
        public int? vote_count { get; set; }
        public object[] voted { get; set; }
        public bool? can_accept_answer { get; set; }
        public bool? can_unaccept_answer { get; set; }
        public bool? accepted_answer { get; set; }
        public bool? can_vote { get; set; }
        public Link_Counts[] link_counts { get; set; }
    }

    public class Link_Counts
    {
        public string url { get; set; }
        public bool? _internal { get; set; }
        public bool? reflection { get; set; }
        public string title { get; set; }
        public int? clicks { get; set; }
    }

    public class Details
    {
        public Created_By created_by { get; set; }
        public Last_Poster last_poster { get; set; }
        public Participant[] participants { get; set; }
        public Link[] links { get; set; }
        public int? notification_level { get; set; }
        public bool? can_flag_topic { get; set; }
    }

    public class Created_By
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
    }

    public class Last_Poster
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
    }

    public class Participant
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
        public int? post_count { get; set; }
        public object primary_group_name { get; set; }
        public object primary_group_flair_url { get; set; }
        public object primary_group_flair_color { get; set; }
        public object primary_group_flair_bg_color { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string title { get; set; }
        public bool? _internal { get; set; }
        public bool? attachment { get; set; }
        public bool? reflection { get; set; }
        public int? clicks { get; set; }
        public int? user_id { get; set; }
        public string domain { get; set; }
        public string root_domain { get; set; }
    }

    public class Last_Answerer
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string avatar_template { get; set; }
    }

    public class Suggested_Topics
    {
        public int? id { get; set; }
        public string title { get; set; }
        public string fancy_title { get; set; }
        public string slug { get; set; }
        public int? posts_count { get; set; }
        public int? reply_count { get; set; }
        public int? highest_post_number { get; set; }
        public object image_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_posted_at { get; set; }
        public bool? bumped { get; set; }
        public DateTime bumped_at { get; set; }
        public bool? unseen { get; set; }
        public bool? pinned { get; set; }
        public object unpinned { get; set; }
        public bool? visible { get; set; }
        public bool? closed { get; set; }
        public bool? archived { get; set; }
        public object bookmarked { get; set; }
        public object liked { get; set; }
        public object[] tags { get; set; }
        public string archetype { get; set; }
        public int? like_count { get; set; }
        public int? views { get; set; }
        public int? category_id { get; set; }
        public object featured_link { get; set; }
        public Poster[] posters { get; set; }
    }

   

    public class Actions_Summary
    {
        public int? id { get; set; }
        public int? count { get; set; }
        public bool? hidden { get; set; }
        public bool? can_act { get; set; }
    }

}
