class HomeController < ApplicationController
  def index
    @chapters = Chapter.all
  end

  def meet
  end
end
