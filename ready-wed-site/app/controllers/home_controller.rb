class HomeController < ApplicationController
  def index
  	@user = User.find(flash[:userid]) unless !User.exists?(:id => flash[:userid])
    @chapters = Chapter.all
  end

  def meet
  	@author = Author.find(1)
  end
end
