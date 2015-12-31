chapters = [
    {:id => "1",    :title => "Life Long Commitment",                   :summary => "Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day."},
    {:id => "2",    :title => "Spending Enjoyable Time Together",       :summary => "In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together."},
    {:id => "3",    :title => "Positive Communication",                 :summary => "Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her."},
    {:id => "4",    :title => "Shared Spiritual Intimacy",              :summary => "Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy."},
    {:id => "5",    :title => "Healthy Individuals",                    :summary => "A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development."},
    {:id => "6",    :title => "Mutually Satisfying Physical Intimacy",  :summary => "Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh."},
    {:id => "7",    :title => "Healthy Conflict Management",            :summary => "Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection."},
    {:id => "8",    :title => "Shared Responsibility (Teamwork)",       :summary => "Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you."},
    {:id => "9",    :title => "Coping With Change, Stress and Crises",  :summary => "You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing."},
    {:id => "10",   :title => "Cherish",                                :summary => "Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse."},
    {:id => "11",   :title => "Nourish",                                :summary => "Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her."},
    {:id => "12",   :title => "Community-Mindedness",                   :summary => "Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage."}
]

chapters.each do |c|
    Chapter.create!(c)
end