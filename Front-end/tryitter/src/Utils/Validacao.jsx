const isValidEmail = (email) => {
  console.log('validando email');
  const regex = /^[a-z0-9.]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/i;
  console.log(regex.test(email));
  return regex.test(email);
};

const isValidPassword = (password, minLength = 0) => (password.length > minLength);

const isValidName = (name, minLength = 1) => (name.length > minLength);

export {
  isValidEmail,
  isValidPassword,
  isValidName,
};
