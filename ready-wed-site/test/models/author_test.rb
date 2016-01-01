require 'test_helper'

class AuthorTest < ActiveSupport::TestCase
	test "the schema of the table 'authors'" do
		author = Author.find(1)

		assert_respond_to author, :id, "Author model does not respond to 'id'."
		assert_respond_to author, :name, "Author model does not respond to 'name'."
		assert_respond_to author, :about, "Author model does not respond to 'about'."

		assert_not_respond_to author, :nonsense, "Author model is responding to 'nonsense'. That's dumb."
	end

	test "should not save author without populated fields" do
		author = Author.new
		assert_not author.save, "The author was saved with nil fields."
	end
end
