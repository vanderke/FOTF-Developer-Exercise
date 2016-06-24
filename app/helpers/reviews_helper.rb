module ReviewsHelper
  def reviewed_on(review)
    review.created_at
  end

  def reviewed_on_format(review)
    reviewed_on(review).strftime("%b %d, %Y")
  end
end
