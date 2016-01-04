class HomeController < ApplicationController
  def index
  	@name = User.find(session[:user_id]).name unless !User.exists?(:id => session[:user_id])
    @chapters = Chapter.all
  end

  def meet
  	@author = Author.find(1)
  end
end
