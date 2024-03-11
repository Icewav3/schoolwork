# 2. Write a function that reads the text file into a string, one line at a time, and looks for the line containing the word “Aqua”, and replaces that line with:

# Azure #007fff

# 3. Write another function to overwrite the original file with the modified text, so the original file looks like:

# Amethyst #9966cc
# Apricot #fbceb1
# Azure #007fff
# Blond #faf0be

basestring = "Amethyst #9966cc\nApricot #fbceb1\nAqua #00ffff\nBlond #faf0be"

filename = "colors.txt"

def read_file(file_name):
    """
    Read the contents of a file and replace any occurrence of the word "Aqua" with "Azure #007fff".

    Args:
        file_name (str): The name of the file to be read.

    Returns:
        list: A list of lines from the file, with the word "Aqua" replaced by "Azure #007fff".
    """
    with open(file_name, "r") as file:
        lines = file.readlines()
        for i in range(len(lines)):
            if "Aqua" in lines[i]:
                lines[i] = "Azure #007fff\n"
    return lines

def write_file(file_name, lines):
    """_summary_

    Args:
        file_name (_type_): _description_
        lines (_type_): _description_
    """
    with open(file_name, "w") as file:
        file.writelines(lines)

write_file(filename, basestring)
newtext = read_file(filename)
print(newtext)
write_file(filename, newtext)