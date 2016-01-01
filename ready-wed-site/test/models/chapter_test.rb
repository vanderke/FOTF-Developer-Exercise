require 'test_helper'

class ChapterTest < ActiveSupport::TestCase
	test "the schema of the table 'chapters'" do
		chapter = Chapter.find(1)

		assert_respond_to chapter, :id
		assert_respond_to chapter, :title 
		assert_respond_to chapter, :summary

		assert_not_respond_to chapter, :nonsense
	end

	test "the content of the first chapter" do
		chapter = Chapter.find(1)

		assert_equal chapter.id, 1, "The chapter.id was not 1"
		assert_match /Life Long/, chapter.title, "Life Long was not found in the chapter.title"
		assert_match /divorce is not an option/, chapter.summary, "'divorce is not an option' was not found in chapter.summary"
	end

	test "should not save chapter without populated fields" do
		chapter = Chapter.new
		assert_not chapter.save, "The chapter was saved with nil fields."
	end
end
