class ReviewsController < ApplicationController
  before_action :set_lesson

  def index
    @reviews = @lesson.reviews
  end

  def new
    @review = @lesson.reviews.new
  end

  def create
    @review = @lesson.reviews.new(review_params)
    if @review.save
      redirect_to lesson_reviews_path(@lesson),
        notice: "Thanks for your review!"
    else
      render :new
    end
  end

private

  def review_params
    params.require(:review).permit(:comment)
  end

  def set_lesson
    @lesson = Lesson.find(params[:lesson_id])
  end

end
