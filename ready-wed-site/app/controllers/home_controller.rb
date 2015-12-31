class HomeController < ApplicationController
  def index
    @chapters = Chapter.all
  end
end
