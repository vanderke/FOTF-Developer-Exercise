require 'rails_helper'

describe "A lesson" do
  it "requires a chapter" do
    lesson = Lesson.new(chapter: "")

    lesson.valid?

    expect(lesson.errors[:chapter].any?).to eq(true)
  end

  it "requires a title" do
    lesson = Lesson.new(title: "")

    lesson.valid?

    expect(lesson.errors[:title].any?).to eq(true)
  end

  it "requires a summary" do
    lesson = Lesson.new(summary: "")

    lesson.valid?

    expect(lesson.errors[:summary].any?).to eq(true)
  end
end
