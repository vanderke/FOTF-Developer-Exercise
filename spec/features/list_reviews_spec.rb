require 'rails_helper'

describe "Viewing a list of reviews" do
  it "shows the reviews for a specific lesson" do
    lesson1 = Lesson.create!(lesson_attributes(title: "Wed for Life"))
    review1 = lesson1.reviews.create!(review_attributes(comment:"Worth it, but tough"))
    review2 = lesson1.reviews.create!(review_attributes(comment:"A life of togetherness"))

    lesson2 = Lesson.create!(lesson_attributes(title: "Traditional Roles"))
    review3 = lesson2.reviews.create!(review_attributes(comment:"Bread winner vs. homemaker"))

    visit lesson_reviews_url(lesson1)

    expect(page).to have_text(review1.comment)
    expect(page).to have_text(review2.comment)
    expect(page).not_to have_text(review3.comment)
  end

end
