class HomeController < ApplicationController
  def index
  	@user = User.find(session[:user_id]) unless !User.exists?(:id => session[:user_id])
    @chapters = Chapter.all
  end

  def meet
  	@author = Author.find(1)
  end
end
