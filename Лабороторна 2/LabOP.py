class word(object):
	numbers = "0123456789"
	def __init__(self):
		pass
	def __init__(self, content):
		self.content = content
	def CountNumbersInWord(self):
		count = 0
		for i in range(1,len(self.content)):
			if self.numbers.__contains__(self.content[i]):
				count+=1
		return count


class Functions():
	staticmethod
	def FindNumberOfNumbersInWords(self):
		print("Enter words:")
		w = word(input())
		print(w.CountNumbersInWord())


Functions.FindNumberOfNumbersInWords(Functions)
