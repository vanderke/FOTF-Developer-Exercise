require 'rails_helper'

describe "A review" do
  it "belongs to a lesson" do
    lesson = Lesson.create(lesson_attributes)

    review = lesson.reviews.new(review_attributes)

    expect(review.lesson).to eq(lesson)
  end

  it "with example attributes is valid" do
    review = Review.new(review_attributes)

    expect(review.valid?).to eq(true)
  end

  it "requires a comment" do
    review = Review.new(comment: "")

    review.valid?

    expect(review.errors[:comment].any?).to eq(true)
  end
end
