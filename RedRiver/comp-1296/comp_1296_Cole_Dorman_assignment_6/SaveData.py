import os

class DataHandler:
    """
    A class that handles reading and writing data to a file.

    Args:
        filename (str): The name of the file to read from or write to.
    """

    def __init__(self, filename):
        self.filename = filename

    def write_data(self, data: dict):
        """
        Writes the given data to the file.

        If the file already exists, the data will be appended to the end of the file.
        If the file does not exist, a new file will be created and the data will be written to it.

        Args:
            data (dict): The data to write to the file. Should be a dictionary where the keys are strings and the values are strings.
        """
        if os.path.isfile(self.filename):
            mode = 'a'  # Append mode
        else:
            mode = 'w'  # Write mode

        with open(self.filename, mode) as file:
            for key, value in data.items():
                file.write(f"{key}: {value}\n")

    def read_data(self):
        """
        Reads the data from the file and returns it as a list of dictionaries.
        
        Returns:
            list: The data read from the file. Each item in the list is a dictionary where the keys are strings and the values are strings.
        """
        data = []
        with open(self.filename, 'r') as file:  # r = read, w = write, a = append
            current_dict = {}
            for line in file:
                if line.strip() == "":
                    if current_dict:
                        data.append(current_dict)
                        current_dict = {}
                else:
                    key, value = line.strip().split(': ')
                    if key in current_dict:
                        data.append(current_dict)
                        current_dict = {}
                    current_dict[key] = value
            if current_dict:
                data.append(current_dict)
        return data