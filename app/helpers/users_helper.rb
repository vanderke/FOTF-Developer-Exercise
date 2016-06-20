module UsersHelper
  
  def member_since(user)
    user.created_at
  end

  def member_since_format(user)
    member_since(user).strftime("%B, %Y")
  end

end
