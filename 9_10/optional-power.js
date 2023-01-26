console.log(optionalPow(2, 3));
function optionalPow(a, b) {
  let confirm = window.confirm(
    `Do you want to raise ${a} to the power of ${b}?`
  );
  if (confirm) {
    return Math.pow(a, b);
  } else {
    return Math.pow(b, a);
  }
}
