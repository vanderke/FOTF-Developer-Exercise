class HomeController < ApplicationController
  def index
    @chapters = Chapter.all
  end

  def meet
  	@author = Author.find(1)
  end
end
