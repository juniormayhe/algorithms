function removeProperty(obj, prop) {
  if (obj.hasOwnProperty(prop))
    return delete obj[prop];
  else
    return false;
}